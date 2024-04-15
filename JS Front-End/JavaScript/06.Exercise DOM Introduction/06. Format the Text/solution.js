function solve() {
  const arrayOfSentences = document.getElementById('input').value.split('.');
  arrayOfSentences.pop();
  for (const iterator of arrayOfSentences) {
    if (iterator === '') {
      arrayOfSentences.slice(arrayOfSentences.indexOf(iterator), 1);
    }
  }
  const lengthOfArray = arrayOfSentences.length;
  let index = 0;
  while (index < lengthOfArray) {
    const paragraph = document.createElement('p');
    let text = '';
    while((index+1)%3!==0 && index+1<lengthOfArray ) {
      text+=arrayOfSentences[index++]+'.';
      console.log(index);
    }
    text+=arrayOfSentences[index++]+'.';
    const paragraphText=document.createTextNode(text);
    paragraph.appendChild(paragraphText);
    document.getElementById('output').appendChild(paragraph);
  }
}