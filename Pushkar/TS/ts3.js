var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Student = /** @class */ (function () {
    function Student(id, name, age) {
        this.id = id;
        this.name = name;
        this.age = age;
    }
    // Method to display student information
    Student.prototype.displayInfo = function () {
        console.log("Student ID: ".concat(this.id));
        console.log("Student Name: ".concat(this.name));
        console.log("Student Age: ".concat(this.age));
    };
    return Student;
}());
// Creating instances of Student class
var student1 = new Student(1, "Alice", 20);
var student2 = new Student(2, "Bob", 22);
// Accessing public properties and methods
console.log(student1.name);
student1.displayInfo();
// Attempting to access private property (will result in an error)
//console.log(student1.id); // Error: Property 'id' is private
//======================
// Inheritance
var CollegeStudent = /** @class */ (function (_super) {
    __extends(CollegeStudent, _super);
    function CollegeStudent(id, name, age, collegeName) {
        var _this = _super.call(this, id, name, age) || this;
        _this.collegeName = collegeName;
        return _this;
    }
    // Override the displayInfo method
    CollegeStudent.prototype.displayInfo = function () {
        _super.prototype.displayInfo.call(this);
        // console.log(super.age); // Call the parent class method
        console.log("College Name: ".concat(this.collegeName));
    };
    return CollegeStudent;
}(Student));
// Creating an instance of CollegeStudent
var collegeStudent = new CollegeStudent(3, "Charlie", 21, "XYZ College");
// Accessing properties and methods from the base class
console.log(collegeStudent.name); // Output: Charlie
collegeStudent.displayInfo();
// Attempting to access protected property (can be accessed in derived classes)
//console.log(collegeStudent.age); // Error: Property 'age' is protected
//=======================
var MathUtil = /** @class */ (function () {
    function MathUtil() {
    }
    MathUtil.add = function (x, y) {
        return x + y;
    };
    MathUtil.PI = 3.14159;
    return MathUtil;
}());
console.log(MathUtil.PI);
var sum = MathUtil.add(5, 3);
console.log(sum);
//==============
