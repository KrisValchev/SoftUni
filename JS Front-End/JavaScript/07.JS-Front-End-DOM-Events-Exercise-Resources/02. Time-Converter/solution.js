function attachEventsListeners() {

   const dayBtn=document.getElementById('daysBtn');
   dayBtn.addEventListener('click',(event)=>{
    const days=document.getElementById('days').value;
    document.getElementById('hours').value=days*24;
    document.getElementById('minutes').value=days*24*60;
    document.getElementById('seconds').value=days*24*60*60;
   })

   const hoursBtn=document.getElementById('hoursBtn');
   hoursBtn.addEventListener('click',(event)=>{
    const hours=document.getElementById('hours').value;
    document.getElementById('days').value=hours/24;
    document.getElementById('minutes').value=hours*60;
    document.getElementById('seconds').value=hours*60*60;
   })

   const minutesBtn=document.getElementById('minutesBtn');
   minutesBtn.addEventListener('click',(event)=>{
    const minutes=document.getElementById('minutes').value;
    document.getElementById('days').value=minutes/(24*60);
    document.getElementById('hours').value=minutes/60;
    document.getElementById('seconds').value=minutes*60;
   })
   const secondsBtn=document.getElementById('secondsBtn');
   secondsBtn.addEventListener('click',(event)=>{
    const seconds=document.getElementById('seconds').value;
    document.getElementById('days').value=seconds/(24*60*60);
    document.getElementById('hours').value=seconds/(60*60);
    document.getElementById('minutes').value=seconds/60;
   })
}