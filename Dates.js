let myDate=new Date();
console.log(myDate.toString());
console.log(myDate.toDateString);
console.log(myDate.toLocaleString())

let myCreateDate=new Date(2023,9,10) // month will be start with 0 in js
console.log(myCreateDate.toString());

let myTimeStamp=Date.now()
console.log(myTimeStamp);
console.log(myCreateDate.getTime());
console.log(Math.floor(Date.now()/1000));
//newDate.toLocaleString('default',{weekday:"long",});

