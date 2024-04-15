function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const trElements = document.querySelectorAll('table.container tbody tr');
      const searchFieldElement = document.getElementById('searchField');
      const searchText = searchFieldElement.value;
     
      for (const trElement of trElements) {
         const tdElements = trElement.querySelectorAll('td');
         let isSelected = false;
         trElement.className = '';
         for (const tdElement of tdElements) {
            if (tdElement.textContent.includes(searchText)) {
               isSelected = true;
               break;
            }
         }
         if (isSelected) {
            trElement.className = 'select';
         }
      }
      searchFieldElement.value = '';
   }
}