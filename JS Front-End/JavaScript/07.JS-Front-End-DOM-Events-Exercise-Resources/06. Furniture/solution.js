function solve() {
  const textareaInputElement = document.querySelector('#exercise textarea:first-of-type');
  const textAreaOutputElement = document.querySelector('#exercise textarea:last-of-type');
  const generateButtonElement = document.querySelector('#exercise button:first-of-type');
  const buyButtonElement = document.querySelector('#exercise button:last-of-type');
  const furnitureTbodyElement = document.querySelector('.table tbody');

  generateButtonElement.addEventListener('click', (e) => {
    const furnitures = JSON.parse(textareaInputElement.value);

    for (const furniture of furnitures) {
      const imgElement = document.createElement('img');
      imgElement.src = furniture.img;
      const imageTdElement = document.createElement('td');
      imageTdElement.appendChild(imgElement);

      const namePElement = document.createElement('p');
      namePElement.textContent = furniture.name;
      const nameTdlement = document.createElement('td');
      nameTdlement.appendChild(namePElement);

      const pricePElement = document.createElement('p');
      pricePElement.textContent = furniture.price;
      const pricePTdElement = document.createElement('td');
      pricePTdElement.appendChild(pricePElement);

      const decPElement = document.createElement('p');
      decPElement.textContent = furniture.decFactor;
      const decPTdElement = document.createElement('td');
      decPTdElement.appendChild(decPElement);

      const markElement = document.createElement('input');
      markElement.setAttribute('type', 'checkbox');
      const markTdElement = document.createElement('td');
      markTdElement.appendChild(markElement);

      const furnitureTrElement = document.createElement('tr');
      furnitureTrElement.appendChild(imageTdElement);
      furnitureTrElement.appendChild(nameTdlement);
      furnitureTrElement.appendChild(pricePTdElement);
      furnitureTrElement.appendChild(decPTdElement);
      furnitureTrElement.appendChild(markTdElement);

      furnitureTbodyElement.appendChild(furnitureTrElement);

    }
  });

  buyButtonElement.addEventListener('click', (e) => {
    let names = [];
    let totalPrice = 0;
    let marked=0;
    let totalDecorationFactor = 0;
    Array.from(furnitureTbodyElement.children).forEach(f => {
      const markInputElement = f.querySelector('input[type=checkbox]')
      if (!markInputElement.checked) {
        return;
      }
      const name = f.children.item(1).textContent;
      const price = Number(f.children.item(2).textContent);
      const decorationFactor = Number(f.children.item(3).textContent);

      names.push(name);
      totalPrice += price;
      totalDecorationFactor += decorationFactor;
marked++;
    })
    const average=totalDecorationFactor/marked;
    textAreaOutputElement.textContent+=`Bought furniture: ${names.join(', ')}\n`;
    textAreaOutputElement.textContent+=`Total price: ${totalPrice.toFixed(2)}\n`;
    textAreaOutputElement.textContent+=`Average decoration factor: ${average}`;
  });
}