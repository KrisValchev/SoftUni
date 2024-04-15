function generateReport() {
    const checkBoxes = document.querySelectorAll('thead tr th input');
    let arrayOfReports = [];
    console.log(checkBoxes);
    for (let i = 0; i < checkBoxes.length; i++) {
        if (checkBoxes[i].checked) {
            const trElements = document.querySelectorAll('tbody tr');
            for (let j = 0; j < trElements.length; j++) {
               if(arrayOfReports[j]==undefined){
                arrayOfReports[j]={[checkBoxes[i].name]:trElements[j].children[i].textContent};
               }else{
                arrayOfReports[j][checkBoxes[i].name]=trElements[j].children[i].textContent;
               }
            }
        }
    }
    document.getElementById('output').textContent=JSON.stringify(arrayOfReports);
}