function lockedProfile() {
    for (const profile of document.querySelectorAll('.profile')) {
        const button = profile.getElementsByTagName('button')[0];
        button.addEventListener('click', (event) => {
            const lockRadioButton = profile.getElementsByTagName('input')[0];
                const moreInfo = profile.getElementsByTagName('div')[0];
            if (event.target.textContent === 'Show more') {
                
                if (!lockRadioButton.checked) { 
                    moreInfo.style.display = 'block';
                    event.target.textContent='Hide it';
                }
            } else {
                if (!lockRadioButton.checked) {
                    moreInfo.style.display = 'none';
                    event.target.textContent='Show more';
                }
            }
        });
    }
}