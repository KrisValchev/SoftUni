function attachEvents() {
    const baseUrl = 'http://localhost:3030/jsonstore/phonebook';
    const loadButtonElement = document.getElementById('btnLoad');
    const bntCreateButtonElement = document.getElementById('btnCreate');
    const phonebookElement = document.getElementById('phonebook');
    const personElement = document.getElementById('person');
    const phoneElement = document.getElementById('phone');

    loadButtonElement.addEventListener('click', () => {
        phonebookElement.innerHTML='';
        fetch(baseUrl)
        .then(response => response.json())
            .then(data => {
                Object.values(data)
                    .forEach(entry => {
                        phonebookElement.appendChild(createEntryElement(entry));
                    });



            });
    });

    bntCreateButtonElement.addEventListener('click', () => {
      fetch(baseUrl,{
        method:'POST',
        headers:{
            'content-type':'application/json'
        },
            body:JSON.stringify({
                person: personElement.value,
                phone: phoneElement.value
            }),
        }
      ).then((res)=>res.json())
      .then(entry=>{
        const liElement = createEntryElement(entry);
        phonebookElement.appendChild(liElement);
        personElement.value='';
        phoneElement.value='';
      });
        
    });
    function createEntryElement(entry) {

        const liElement = document.createElement('li');
        liElement.textContent = `${entry.person}: ${entry.phone}`;
    
        const deleteBtn = document.createElement('button');
        deleteBtn.textContent = 'Delete';
        deleteBtn.addEventListener('click',()=>{
            fetch(`${baseUrl}/${entry._id}`,{
                method:'DELETE'
            }).then(()=>{
                liElement.remove();
            })
        })
        liElement.appendChild(deleteBtn);
        
        return liElement;
    
    }
}


attachEvents();