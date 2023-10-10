// Arrays

 const myarray=[0,12,3,4,5]
 const myheroes=["nagraj","shaktiman","Dnagin"]

 console.log(myarray[1]);
 console.log(myheroes);
// myarray.shift();    it is same like as pop and push in thhe c++ and c
   myarray.unshift();
   console.log(myarray);


   console.log(myarray.includes(9));
  console.log(myarray.indexOf(3));

  const newArr=myarray.join() 
  console.log(myarray);
  console.log(newArr);
  

  //Slice or splice
  const myn1=myarray.slice(1,3)
  console.log(myn1);
  console.log("B",myarray);

  const mynew2=myarray.splice(1,3)
  console.log(mynew2);
  console.log(myarray);

 // difference between slice and splice
 //the diff is between this two method which is slice has a print the numbers between those 
 //we are declared here example(1,3){0,1,2} third number will not be printed.

// splice manipulate the original array [0,3]={1,2,3}
 