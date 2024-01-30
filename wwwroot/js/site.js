
let phoneIndex = 1;
function addPhoneNumber() {
    let cloneField = document.getElementById('phoneNumberField').cloneNode(true);

    cloneField.querySelector('input').setAttribute('name', `PhoneNumber[${phoneIndex}]`);
    cloneField.querySelector('input').value = '';
    //cloneField.querySelector('input').setAttribute('id', '');

    let parentDiv = document.getElementById('phoneNumberField').parentNode;
    parentDiv.insertBefore(cloneField, parentDiv.lastElementChild);

    phoneIndex++;
}

let referenceIndex = 1;

function addReference() {
    let referenceNumeration = document.getElementById('referenceNumeration').cloneNode(true);
    let cloneReferenceName = document.getElementById('referenceNameField').cloneNode(true);
    let cloneReferencePhone = document.getElementById('referencePhoneField').cloneNode(true);

    referenceNumeration.innerHTML = `${referenceIndex + 1}º Referência`;

    let parentDiv = document.getElementById('referenceNumeration').parentNode;
    parentDiv.insertBefore(referenceNumeration, parentDiv.lastElementChild);

    cloneReferenceName.querySelector('input').setAttribute('name', `ReferenceName[${referenceIndex}]`);
    cloneReferenceName.querySelector('input').value = '';
    parentDiv.insertBefore(cloneReferenceName, parentDiv.lastElementChild);

    cloneReferencePhone.querySelector('input').setAttribute('name', `ReferenceName[${referenceIndex}]`);
    cloneReferencePhone.querySelector('input').value = '';
    parentDiv.insertBefore(cloneReferencePhone, parentDiv.lastElementChild);

    referenceIndex++;

}