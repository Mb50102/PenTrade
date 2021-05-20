"use strict";






var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;
document.getElementById("sendOfferButton").disabled = true;


var table = document.getElementById("messagesList");
table.tBodies[0].scrollTop = table.tBodies[0].scrollHeight;

function getHours(dateTime) {
    var date = new Date(dateTime);

    var hours = "0" + date.getHours();
    var minutes = "0" + date.getMinutes();
    var seconds = "0" + date.getSeconds();

    return hours.substr(-2) + ":"+ minutes.substr(-2) + ":" + seconds.substr(-2);
}

function getDateString(dateTime) {
    var date = new Date(dateTime)
    const dayOfWeekNames = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
        "Saturday"];
    var dayOfWeek = dayOfWeekNames[date.getDay()];
    var datePart = "0" + date.getDate();
    const monthNames = ["January", "February", "March", "April", "May", "June",
  "July", "August", "September", "October", "November", "December"
];
    var month = monthNames[date.getMonth()];
    var year = date.getFullYear();

    return dayOfWeek +  ", " + datePart.substr(-2) + " " + month + " " + year;
}

connection.on("ReceiveMessage", function (newMessage) {
    var msg = newMessage.content.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = msg; 
    var dateString = getDateString(newMessage.timeSent);
    var timeString = getHours(newMessage.timeSent);
    var table = document.getElementById("messagesList");
    var thisCompanyId = parseInt(document.getElementById("thisCompanyId").value, 10);
    var thisCompanyName = document.getElementById("thisCompanyName").value;
    var otherCompanyName = document.getElementById("otherCompanyName").value;

    var tr = table.insertRow();
    var tdCompanyName = tr.insertCell();
    var tdMessage = tr.insertCell();

    if (newMessage.companyReceiverId === thisCompanyId) {
        tdCompanyName.innerHTML = otherCompanyName + "<br />" + dateString + "<br />" + timeString;
        tdMessage.classList.add("table-primary");
        tdMessage.innerHTML = encodedMsg;

    }
    else {
        tdCompanyName.innerHTML = "&nbsp";
        tdMessage.innerHTML = "&nbsp";
    }


    var tdMessage = tr.insertCell();
    var tdCompanyName = tr.insertCell();
    if (newMessage.companySenderId === thisCompanyId) {
        tdCompanyName.innerHTML = thisCompanyName + "<br />" + dateString+ "<br />" + timeString;
        tdCompanyName.classList.add("text-right");
        tdMessage.classList.add("table-active");
        tdMessage.innerHTML = encodedMsg;
    }
    else {
        tdMessage.innerHTML = "&nbsp";
        tdCompanyName.innerHTML = "&nbsp";
    }

    table.tBodies[0].scrollTop = table.tBodies[0].scrollHeight;
});

connection.start().then(function(){
    document.getElementById("sendButton").disabled = false;
    document.getElementById("sendOfferButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var companySenderId = document.getElementById("thisCompanyId").value;
    var companyReceiverId = document.getElementById("otherCompanyId").value;
    var content = document.getElementById("messageInput").value;
    var currentDateTime = new Date();
    var newMessage = new NewMessageModel(companySenderId, companyReceiverId, content, currentDateTime);
    connection.invoke("SendMessage", newMessage).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

function acceptOffer(event) {
    var offerId = event.currentTarget.parentElement.id;
    modifyOffer(offerId, true);
};

function declineOffer(event) {
    var offerId = event.currentTarget.parentElement.id;
    modifyOffer(offerId, false);
}



function modifyOffer(offerId, newStatus) {
    connection.invoke("ModifyOffer", offerId, newStatus).catch(function(err) {
        return console.error(err.toString());
    });
}

connection.on("GetNotified", function (offerId, newStatus) {
    var offer = document.getElementById(offerId.toString());
    if (newStatus) {
        offer.classList.add("table-success");
    }
    else {
        offer.classList.add("table-danger");
    }
    offer.querySelector("#acceptOfferButton").style.display = "none";
    offer.querySelector("#declineOfferButton").style.display = "none";

});

document.getElementById("sendOfferButton").addEventListener("click", function (event) {
    var isOfferToBuy = document.getElementById("Buy").checked;
    var selectList = null;
    var merchandiseId = 0;
    var merchandiseName = null;
    if (isOfferToBuy) {
        selectList = document.getElementById("thisCompanyMerchandise");

    }
    else {
        selectList = document.getElementById("otherCompanyMerchandise");
    }
    merchandiseId = selectList.options[selectList.selectedIndex].value;
    merchandiseName = selectList.options[selectList.selectedIndex].text;

    var companySenderId = parseInt(document.getElementById("thisCompanyId").value);
    var companyReceiverId = parseInt(document.getElementById("otherCompanyId").value);
    var timeSent = new Date();
    var amount = parseFloat(document.getElementById("amount").value);
    var pricePerUnit = parseFloat(document.getElementById("pricePerUnit").value);

    var newOffer = new NewOfferModel(companySenderId, companyReceiverId, merchandiseId, timeSent, pricePerUnit, amount, merchandiseName, isOfferToBuy);

    connection.invoke("SendNewOffer", newOffer).catch(function (err) {
        return console.error(err.toString());
    });
});

connection.on("RecieveNewOffer", function (newOffer) {
    var merchandiseName = newOffer.merchandiseName;
    var dateString = getDateString(newOffer.timeSent);
    var timeString = getHours(newOffer.timeSent);
    var table = document.getElementById("offersList");
    var thisCompanyId = parseInt(document.getElementById("thisCompanyId").value, 10);
    var thisCompanyName = document.getElementById("thisCompanyName").value;
    var otherCompanyName = document.getElementById("otherCompanyName").value;

    var tr = table.insertRow();
    var tdCompanyName = tr.insertCell();
    var tdMessage = tr.insertCell();

    if (newOffer.receiverId === thisCompanyId) {
        tdCompanyName.innerHTML = otherCompanyName + "<br />" + dateString + "<br />" + timeString;
        tdMessage.id = newOffer.newOfferId;
        tdMessage.innerHTML = "Offer for: " + newOffer.merchandiseName + " <br />";
        tdMessage.innerHTML += "How many: " +  newOffer.amount + " <br />";
        tdMessage.innerHTML += "How much per unit: " + newOffer.pricePerUnit + " <br />";
        tdMessage.innerHTML += "Total price: " +  newOffer.amount * newOffer.pricePerUnit + " <br />";
        tdMessage.innerHTML += "<input type='button' class='btn btn-success' id='acceptOfferButton' value='Accept Offer' onclick='acceptOffer(event)'/>";
        tdMessage.innerHTML += "<input type='button' class='btn btn-danger' id='declineOfferButton' value='Decline Offer' onclick='declineOffer()'/>";
                                    
    }
    else {
        tdCompanyName.innerHTML = "&nbsp";
        tdMessage.innerHTML = "&nbsp";
    }


    var tdMessage = tr.insertCell();
    var tdCompanyName = tr.insertCell();
    if (newOffer.senderId === thisCompanyId) {
        tdCompanyName.innerHTML = thisCompanyName + "<br />" + dateString + "<br />" + timeString;
        tdMessage.id = newOffer.newOfferId;
        tdMessage.innerHTML = "Offer for: " + newOffer.merchandiseName + " <br />";
        tdMessage.innerHTML += "How many: " +  newOffer.amount + " <br />";
        tdMessage.innerHTML += "How much per unit: " + newOffer.pricePerUnit + " <br />";
        tdMessage.innerHTML += "Total price: " +  newOffer.amount * newOffer.pricePerUnit + " <br />";
    }
    else {
        tdMessage.innerHTML = "&nbsp";
        tdCompanyName.innerHTML = "&nbsp";
    }

    table.tBodies[0].scrollTop = table.tBodies[0].scrollHeight;
});

function updateTotalPrice() {
    var totalPrice = document.getElementById("totalPrice");
    var amount = parseFloat(document.getElementById("amount").value);
    var pricePerUnit = parseFloat(document.getElementById("pricePerUnit").value);

    totalPrice.innerText = isNaN(amount * pricePerUnit) ? "Cannot determine" : (amount * pricePerUnit).toString();


}

function changeSelectList() {
    if (document.getElementById("Sell").checked) {
        document.getElementById("thisCompanyMerchandise").style.display = "initial";
        document.getElementById("otherCompanyMerchandise").style.display = "none";
    }
    else if(document.getElementById("Buy").checked){
        document.getElementById("thisCompanyMerchandise").style.display = "none";
        document.getElementById("otherCompanyMerchandise").style.display = "initial";
    }
}

class NewMessageModel {
    constructor(companySenderId, companyReceiverId, content, timeSent, hubConnectionId) {
        this.companySenderId = companySenderId;
        this.companyReceiverId = companyReceiverId;
        this.content = content;
        this.timeSent = timeSent
        this.hubConnectionId = hubConnectionId;
    }
}

class NewOfferModel {
    constructor(senderId, receiverId, merchandiseId, timeSent, pricePerUnit, amount, merchandiseName, isOfferToBuy) {
        this.senderId = senderId;
        this.receiverId = receiverId;
        this.merchandiseId = merchandiseId;
        this.merchandiseName = merchandiseName;
        this.timeSent = timeSent;
        this.pricePerUnit = pricePerUnit;
        this.amount = amount;
        this.isOfferToBuy = isOfferToBuy;
        this.newOfferId = null;
    }

}
