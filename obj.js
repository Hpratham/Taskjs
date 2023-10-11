const obj1={1:"a",2:"b"}
const obj2={3:"a",2:"b"}

const obj3={...obj1,...obj2}
console.log(obj3);

//ans be like :- {1: 'a', 2: 'b', 3: 'a'}

const course={
    coursename:"js in hindi",
    price:"999",
    courseInstructor:"prathmesh"
}
const{courseInstructor}=course
console.log(courseInstructor);