function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick() {
      let array = [];
      array = document.getElementsByTagName('textarea')[0].value;
      array = array.replace('["', '');
      array = array.replace('"]', '');
      array = array.split('","');
      console.log(array);
      let restaurants = {};
      for (let i = 0; i < array.length; i++) {
         restaurants[array[i].split(' - ')[0]] = {};
      }
      for(let i=0;i<array.length;i++){
         for (const iterator of array[i].split(' - ')[1].split(', ')) {
            const nameAndSalary = iterator.split(' ');
            restaurants[array[i].split(' - ')[0]][nameAndSalary[0]] = Number(nameAndSalary[1]);
         }
      }
      let maxAverageSalary = -Infinity;
      let restaurantWithHighestAverage = null;
      for (const restaurant in restaurants) {
         const employees = restaurants[restaurant];
         const totalSalary = Object.values(employees).reduce((acc, curr) => acc + curr, 0);
         const averageSalary = totalSalary / Object.keys(employees).length;
         if (averageSalary > maxAverageSalary) {
            maxAverageSalary = averageSalary;
            restaurantWithHighestAverage = restaurant;
         }
      }
      let maxSalary = -Infinity;
      for (const person in restaurants[restaurantWithHighestAverage]) {
         if (maxSalary < restaurants[restaurantWithHighestAverage][person]) {
            maxSalary = restaurants[restaurantWithHighestAverage][person];
         }
      }
      let bestRestaurantText = `Name: ${restaurantWithHighestAverage} Average Salary: ${maxAverageSalary.toFixed(2)} Best Salary: ${maxSalary.toFixed(2)}`;

      let personAndSalaryArray = Object.entries(restaurants[restaurantWithHighestAverage]);
      personAndSalaryArray.sort((a, b) => b[1] - a[1]);
      let workers = '';
      for (const personAndSalary of personAndSalaryArray) {
         workers += `Name: ${personAndSalary[0]} With Salary: ${personAndSalary[1]} `;
      }
      workers.trimEnd();
      document.getElementById('bestRestaurant').getElementsByTagName('p')[0].textContent = bestRestaurantText;
      document.getElementById('workers').getElementsByTagName('p')[0].textContent = workers;
   }
}