function lockedProfile() {
    const url = 'http://localhost:3030/jsonstore/advanced/profiles';
    const main = document.getElementById('main');
   main.innerHTML='';
    fetch(url)
        .then(response => response.json())
        .then(profiles => {
            Object.values(profiles)
                .forEach((profile,index) => {
                    const divElement = document.createElement('div');
                    divElement.classList.add('profile');
                    divElement.innerHTML = `
                <img src="./iconProfile2.png" class="userIcon" />
                <label>Lock</label>
                <input type="radio" name="user${index + 1}Locked" value="lock" checked>
                    <label>Unlock</label>
                    <input type="radio" name="user${index + 1}Locked" value="unlock"><br>
                        <hr>
                            <label>Username</label>
                            <input type="text" name="user${index + 1}Username" value="${profile.username}" disabled readOnly />
                            <div class="user${index + 1}Username">
                                <hr>
                                    <label>Email:</label>
                                    <input type="email" name="user${index + 1}Email" value="${profile.email}" disabled readOnly />
                                    <label>Age:</label>
                                    <input type="email" name="user${index + 1}Age" value="${profile.age}" disabled readonly />
                            </div>
     
                            <button>Show more</button>`;
                            const userDiv=divElement.querySelector(`.user${index + 1}Username`);
                            userDiv.style.display='none';
                            const btn=divElement.querySelector('button');
                    btn.addEventListener('click', (event) => {
                        const isUnlock = divElement.querySelector('input[type="radio"][value="unlock"]');
                        if (event.target.textContent === 'Show more') {
                            if (isUnlock.checked) {
                                userDiv.style.display = 'block';
                                event.target.textContent = 'Hide it';
                            }
                        } else {
                            if (isUnlock.checked) {
                                userDiv.style.display = 'none';
                                event.target.textContent = 'Show more';
                            }
                        }
                    });
               
                   main.appendChild(divElement);
                })
        });
}