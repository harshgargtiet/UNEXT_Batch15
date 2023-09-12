import './App.css';
import Home from './navigation/Home';
import About from './navigation/About';
import Contact from './navigation/Contact';
import User from './navigation/User';

import {BrowserRouter, Routes ,Route , Link , useNavigate} from 'react-router-dom';
import { useState } from 'react';
import StudentCRUDwithUI from './api/StudentCRUD';

function App() {
  return (
    <div>
    {/* <BrowserRouter>
     <MainApp />
    </BrowserRouter> */}
     <StudentCRUDwithUI />
    </div>
  );
}

const MainApp = () => {
  const [id, setid] = useState('');
  const navigate = useNavigate();

  const sendId = (event) => {
    setid(event.target.value);
  };

  const handleNavigation = () => {
    navigate(`/user/${id}`);
  };

  return (
    <div>
        <nav>
          <ul>
            <li>
              <Link to="/">Home</Link>
            </li>
            <li>
              <Link to="/about">About</Link>
            </li>
            <li>
              <Link to="/contact">Contact</Link>
            </li>
          </ul>
        </nav>
        <input type="text" value={id} onChange={(e) => setid(e.target.value)} ></input>
        <button type="button" onClick={ handleNavigation }>
                Send </button>
        <hr />

        <Routes>
          {/* exact path will match exact letter i.e. case of letter as well */}
          <Route exact path="/"   element = {<Home />} />
          <Route path="/about"    element={<About />} />
          <Route path="/contact"  element={<Contact />} />
          <Route path="/user/:id" element={<User/>} />
        </Routes>

      </div>
    
  );
}
export default App;
