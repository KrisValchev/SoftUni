function attachEvents() {
    const btnLoadPosts = document.getElementById('btnLoadPosts');
    const btnViewPost = document.getElementById('btnViewPost');
    const urlPosts = 'http://localhost:3030/jsonstore/blog/posts';
    const urlComments = 'http://localhost:3030/jsonstore/blog/comments';
    const selectElement = document.getElementById('posts');


    btnLoadPosts.addEventListener('click', (event) => {
        selectElement.innerHTML = '';
        fetch(urlPosts)
            .then(response => response.json())
            .then(posts => {
                Object.values(posts)
                    .forEach(post => {
                        console.log(post);
                        const optionElement = document.createElement('option');
                        optionElement.value = post.postId;
                        optionElement.textContent = post.title;
                        selectElement.appendChild(optionElement);

                    })
            });

    });
    btnViewPost.addEventListener('click', (event) => {
        const postTitle = document.getElementById('post-title');
        const postBody = document.getElementById('post-body');
        const postComments = document.getElementById('post-comments');
        let postId = "";
        postComments.innerHTML='';
   
        fetch(urlPosts)
            .then(response => response.json())
            .then(posts => {
                const post = Object.values(posts)
                    .find(post => post.title === selectElement.options[selectElement.selectedIndex].text);
                    postTitle.textContent = post.title;
                    postBody.textContent = post.body;
                postId = post.id;
            });
        fetch(urlComments)
            .then(response => response.json())
            .then(comments => {

                Object.values(comments)
                    .filter(comment => comment.postId === postId)
                    .forEach(comment => {
                        const liElement = document.createElement('li');
                        liElement.textContent=comment.text;
                        postComments.appendChild(liElement);
                    }
                    );
            })

    });
}

attachEvents();