import React, { useState } from "react";

function ConditionalRendering() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const [name, setName] = useState('');

  return (
    <div>
      {isLoggedIn ? (
        <>
        <p>Welcome, {name}!</p>
        <button onClick={() => 
            {
                setIsLoggedIn(!isLoggedIn)
                setName('baba');
            }}>tata</button>
            </>
        ) : (
        <button onClick={() => 
          {
          setIsLoggedIn(!isLoggedIn)
          setName('John');
        }}
          >Log In {name}</button>
      )}
    </div>
  );
}

export default ConditionalRendering;