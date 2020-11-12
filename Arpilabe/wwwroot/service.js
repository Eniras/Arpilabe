const uri = 'api/People';
let todos = [];

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

function addItem() {
    const FirstNameTextbox = document.getElementById('FirstName');
    const LastNameTextbox = document.getElementById('LastName');
    const MailTextbox = document.getElementById('Mail');
    const PhoneTextbox = document.getElementById('Phone');
    const DepartmentTextbox = document.getElementById('Department');

    const item = {
        FirstName: FirstNameTextbox.value.trim(),
        LastName: LastNameTextbox.value.trim(),
        Email: MailTextbox.value.trim(),
        Phone: PhoneTextbox.value.trim(),
        Departement: DepartmentTextbox.value.trim(),
        Note: ""
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(() => {
            getItems();
            FirstNameTextbox.value = '';
            LastNameTextbox.value = '';
            MailTextbox.value = '';
            PhoneTextbox.value = '';
            DepartmentTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}

function deleteItem(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to delete item.', error));
}

function displayEditForm(id) {
    const item = todos.find(item => item.firstName === firstName);

    document.getElementById('edit-name').value = item.lastName;
    document.getElementById('edit-id').value = item.firstName;
    document.getElementById('edit-isComplete').checked = item.isComplete;
    document.getElementById('editForm').style.display = 'block';
}

function updateItem() {
    const itemId = document.getElementById('edit-id').value;
    const item = {
        id: parseInt(itemId, 10),
        isComplete: document.getElementById('edit-isComplete').checked,
        name: document.getElementById('edit-name').value.trim()
    };

    fetch(`${uri}/${itemId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to update item.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
    const name = (itemCount === 1) ? 'to-do' : 'to-dos';

    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

function _displayItems(data) {
    const tBody = document.getElementById('people');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(item => {
        console.log(item.firstName);
        console.log(item.lastName);
        console.log(item.email);
        console.log(item.phone);

        /*
        let isCompleteCheckbox = document.createElement('input');
        isCompleteCheckbox.type = 'checkbox';
        isCompleteCheckbox.disabled = true;
        isCompleteCheckbox.checked = item.isComplete;

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.firstName})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.firstName})`);
        */

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        let firstName = document.createTextNode(item.firstName);
        td1.appendChild(firstName);

        let td2 = tr.insertCell(1);
        let lastName = document.createTextNode(item.lastName);
        td2.appendChild(lastName);

        let td3 = tr.insertCell(2);
        let email  = document.createTextNode(item.email);
        td3.appendChild(email);

        let td4 = tr.insertCell(3);
        let phone = document.createTextNode(item.phone);
        td4.appendChild(phone);

        let td5 = tr.insertCell(4);
        let departement = document.createTextNode(item.departement);
        td5.appendChild(departement);

        var allTableCells = document.getElementsByTagName("td");

        /*
         for (var i = 0, max = allTableCells.length; i < max; i++) {
            allTableCells[i].style.marginRight = "10px";
        };
        */
        $(document).ready(function () {
            $('#monTableau').DataTable();
        });
    });

    todos = data;
}