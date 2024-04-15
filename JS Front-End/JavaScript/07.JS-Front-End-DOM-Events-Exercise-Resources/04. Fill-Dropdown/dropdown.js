function addItem() {
    const menu = document.getElementById('menu');
    const button = document.querySelector("input[type='button']");
    const newItemText = document.getElementById('newItemText');
    const newItemValue = document.getElementById('newItemValue');
    if (newItemText.value !== '' && newItemValue.value !== '') {
        const option = document.createElement('option');
        option.value = newItemValue.value;
        option.textContent = newItemText.value;
        menu.appendChild(option);
        newItemText.value = '';
        newItemValue.value = '';
    }

}