import React, { useEffect, useState } from "react";
import axios from "axios";

const StudentCRUDwithUI = () => {
  const [students, setStudents] = useState([]);
  const [newStudent, setNewStudent] = useState({
    rollno: "",
    name: "",
    city: "",
  });
  const [editStudent, setEditStudent] = useState({
    rollno: "",
    name: "",
    city: "",
  });

  const basepath = "https://localhost:44388";

  const fetchStudents = async () => {
    try {
      const response = await axios.get(basepath 
        + `/Student`);
      setStudents(response.data);
    } catch (error) {
      console.error(error);
    }
  };

  useEffect(() => {
    fetchStudents();
  }, [students]);

  const createStudent = async () => {
    try {
      const response = await axios.post(basepath + `/Student`, newStudent);
      setStudents([...students, response.data]);
      setNewStudent({ rollno: "", name: "", city: ""});
    } catch (error) {
      console.error(error);
    }
  };

  const updateStudent = async (id) => {
    try {
      const response = await axios.put(
        basepath + `/Student/${id}`, editStudent  );
      setStudents([...students, response.data]);
      } catch (error) {
      console.error(error);
    }
  };

  const deleteStudent = async (id) => {
    try {
      await axios.delete(basepath + `/Student/${id}`);
    } catch (error) {
      console.error(error);
    }
  };

  return (
    <div>
      <h1>Student CRUD Operations</h1>
      <h2>Create Student</h2>
      <h3>{students}</h3>
      <input
        type="text"
        placeholder="Id"
        value={newStudent.rollno}
        onChange={(e) =>
          setNewStudent({ ...newStudent, rollno: e.target.value })
        }
      />
      <input
        type="text"
        placeholder="Name"
        value={newStudent.name}
        onChange={(e) => setNewStudent({ ...newStudent, name: e.target.value })}
      />
      <input
        type="text"
        placeholder="City"
        value={newStudent.city}
        onChange={(e) => setNewStudent({ ...newStudent, city: e.target.value })}
      />
     
      <button onClick={createStudent}>Create Student</button>

      <ul>
        {students.map((student) => (
          <li key={student.rollno}>
            <span>{student.rollno}</span> &nbsp; &nbsp; &nbsp;
            <span>{student.name}</span> &nbsp; &nbsp; &nbsp;
            <span>{student.city}</span> &nbsp; &nbsp; &nbsp;
            {
            editStudent === student.rollno ? (
              <React.Fragment>
                <input
                  type="text"
                  value={editStudent.rollno}
                  onChange={(e) =>
                    setEditStudent({ ...editStudent, rollno: e.target.value })
                  }
                />
                <input
                  type="text"
                  placeholder="Name"
                  value={editStudent.name}
                  onChange={(e) =>
                    setEditStudent({ ...editStudent, name: e.target.value })
                  }
                />
                <input
                  type="text"
                  placeholder="City"
                  value={editStudent.city}
                  onChange={(e) =>
                    setEditStudent({ ...editStudent, city: e.target.value })
                  }
                />
                
                <button onClick={() => updateStudent(student.rollno)}>
                  Save
                </button>{" "}
                &nbsp; &nbsp; &nbsp;
                <button onClick={() => setEditStudent(null)}>
                  Cancel
                </button>{" "}
                &nbsp; &nbsp; &nbsp;
              </React.Fragment>
            ) : (
              <button onClick={() => { 
                setEditStudent(student.rollno)
                console.log(editStudent.rollno);
                 }}>
                Edit
              </button>
            )}
            <button onClick={() => deleteStudent(student.rollno)}>
              Delete
            </button>
            </li>     
            ))}
      </ul>
    </div>
    );

}

export default StudentCRUDwithUI;