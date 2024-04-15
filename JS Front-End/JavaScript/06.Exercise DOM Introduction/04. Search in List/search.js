function search() {
   const searchText = document.getElementById('searchText');
   const cities = document.getElementById('towns').children;
   
   let count = 0;
   let array=Array.from(cities);
   for (const element of array) {
      if (element.textContent.toLowerCase().includes(searchText.value.toLowerCase())) {
         count++;
         element.style.textDecoration = 'underline';
         element.style.fontWeight = 'bold';
      }else{
         element.style.textDecoration = 'none';
         element.style.fontWeight = 'normal';
      }
   }
   document.getElementById('result').textContent=`${count} matches found`;
}
