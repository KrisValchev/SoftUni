function solve() {
  let textArray = document.getElementById('text').value.split(' ');
  let textCase = document.getElementById('naming-convention').value;
  let result = document.getElementById('result');
  const convertor = {
    'Pascal Case': (array) => array
      .map(word => word
        .charAt(0)
        .toUpperCase() + word
          .slice(1)
          .toLowerCase())
      .join(''),
    'Camel Case': (array) => array.map(word => word
      .charAt(0)
      .toUpperCase() + word
        .slice(1)
        .toLowerCase())
      .join('')
      .charAt(0)
      .toLowerCase()+ array.map(word => word
        .charAt(0)
        .toUpperCase() + word
          .slice(1)
          .toLowerCase())
        .join('').slice(1)
  }
  if (convertor[textCase] !== undefined) {
    result.textContent = convertor[textCase](textArray);
  }else{
    result.textContent='Error!';
  }
}
