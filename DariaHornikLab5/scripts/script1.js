//pobranie elementu po id
var contact = document.getElementById('linkedin');

//deklaracja fukcji, wyœwietlaj¹cej alert
function getInformationEventHandler() {
    alert('FunkcjonalnoÅ›Ä‡ w remoncie.');
};

//reakcja na klikniêcie na pobrany element
contact.addEventListener('click', getInformationEventHandler, false);
