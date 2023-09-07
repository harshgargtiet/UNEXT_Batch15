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
// Create an abstract class that implements the Student interface
var AbstractStudent = /** @class */ (function () {
    function AbstractStudent(id, name, age) {
        this.id = id;
        this.name = name;
        this.age = age;
    }
    // Implement the displayInfo method required by the interface
    AbstractStudent.prototype.displayInfo = function () {
        console.log("Student ID: ".concat(this.id));
        console.log("Student Name: ".concat(this.name));
        console.log("Student Age: ".concat(this.age));
    };
    return AbstractStudent;
}());
// Create a concrete class that extends the abstract class
var CollegeStudent = /** @class */ (function (_super) {
    __extends(CollegeStudent, _super);
    function CollegeStudent(id, name, age, collegeName) {
        var _this = _super.call(this, id, name, age) || this;
        _this.collegeName = collegeName;
        return _this;
    }
    // Implement the abstract study method
    CollegeStudent.prototype.study = function () {
        console.log("".concat(this.name, " is studying at ").concat(this.collegeName));
    };
    return CollegeStudent;
}(AbstractStudent));
// Create an instance of the CollegeStudent class
var student = new CollegeStudent(1, "Alice", 20, "XYZ College");
// Access properties and methods
student.displayInfo();
student.study();
