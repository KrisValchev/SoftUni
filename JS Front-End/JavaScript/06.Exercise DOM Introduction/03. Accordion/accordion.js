function toggle() {
    const buttonElement = document.querySelector('.head span.button');
    const extraText = document.getElementById('extra');
    const text=buttonElement.textContent;
    if (text === 'More') {
        extraText.style.display = 'block';
        buttonElement.textContent = 'Less';
    } else {
        extraText.style.display = 'none';
        buttonElement.textContent = 'More';
    }
}