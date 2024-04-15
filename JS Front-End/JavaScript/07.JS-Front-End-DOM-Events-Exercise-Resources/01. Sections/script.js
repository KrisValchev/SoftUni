function create(words) {
   let arrayOfDivs=[];
   const content=document.getElementById('content');
   for (const text of words) {
      const div=document.createElement('div');
      const paragraph=document.createElement('p');
      paragraph.textContent=text;
      paragraph.style.display='none';
      div.appendChild(paragraph);
      content.appendChild(div);
   }
   
   for (const div of content.getElementsByTagName('div')) {
      div.addEventListener('click',(event)=>{
      const paragraphs=div.getElementsByTagName('p')[0];
      paragraphs.style.display='block';
   })}

}