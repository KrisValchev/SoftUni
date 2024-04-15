function encodeAndDecodeMessages() {
    const textarea1 = document.querySelector('#main div:first-of-type').querySelector('textarea');
    const textarea2 = document.querySelector('#main div:last-of-type').querySelector('textarea');
    const encodeButton = document.querySelector('#main div:first-of-type').querySelector('button');
    const decodeButton =document.querySelector('#main div:last-of-type').querySelector('button');
    encodeButton.addEventListener('click', (e) => {
        const text = textarea1.value;
        let encodedText = '';
        for (let i = 0; i < text.length; i++) {
            encodedText += String.fromCharCode(text[i].charCodeAt(0) + 1);
        }
        textarea2.value=encodedText;
        textarea1.value = '';
    });
    decodeButton.addEventListener('click', (e) => {
        if (textarea2.value !== 'No messages...') {
            const text = textarea2.value;
            let decodedText = '';
            for (let i = 0; i < text.length; i++) {
                decodedText += String.fromCharCode(text[i].charCodeAt(0) - 1);
            }
            textarea2.value = decodedText;
            textarea1.value = '';
        }
    });
}