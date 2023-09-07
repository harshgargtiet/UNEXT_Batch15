class Animal {
  constructor(name) {
    this.name = name;
  }
  speak() {
    console.log(`${this.name} makes a sound.`);
  }
}

// const animal = new Animal("General Animal");
// animal.speak(); 




// Subclass extending Animal
class Dog extends Animal {
  constructor(name, breed) {
    super(name); 
    this.breed = breed;
  }

  speak() {
    console.log(`${this.name} ${this.breed} barks loudly`);
  }

  fetch() {
    console.log(`${this.name} can fetch a ball.`);
  }
}


const dog1 = new Dog("Buddy", "Golden Retriever");
dog1.speak();       
dog1.fetch();         
