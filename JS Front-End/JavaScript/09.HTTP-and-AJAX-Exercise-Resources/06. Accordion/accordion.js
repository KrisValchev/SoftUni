function solution() {
    const url = 'http://localhost:3030/jsonstore/advanced/articles/';
    const section = document.getElementById('main');
    fetch(url + `list`)
        .then(res => res.json())
        .then(data => {

            Object.values(data)
                .forEach(article => {
                    const accordion = document.createElement('div');
                    accordion.className = 'accordion';
                    const head = document.createElement('div');
                    head.className = 'head';
                    head.innerHTML = `<span>${article.title}</span>
                <button class="button" id="${article._id}">More</button>`;
                    accordion.appendChild(head);
                    section.appendChild(accordion);
                    fetch(url + `details/${article._id}`)
                        .then(res => res.json())
                        .then(data => {
                            console.log(data.content);
                            const extra = document.createElement('div');
                            extra.className = 'extra';
                            const p = document.createElement('p');
                            p.textContent = data.content;
                            extra.appendChild(p);
                            accordion.appendChild(extra);
                            const btn = document.getElementById(`${article._id}`);
                            btn.addEventListener('click', (e) => {
                                if (e.target.textContent === 'MORE') {
                                    extra.style.display = 'block';
                                    e.target.textContent = 'LESS';
                                } else {
                                    extra.style.display = 'none';
                                    e.target.textContent = 'MORE';
                                }
                            }
                            )

                        });
                })

        });
}
solution(); 