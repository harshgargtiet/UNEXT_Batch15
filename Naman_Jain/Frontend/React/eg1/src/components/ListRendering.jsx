import React from 'react';

function ListRendering() {
  const items = ['Item 1', 'Item 2', 'Item 3'];

  return (
    <ul>
      {items.map((item, index) => (
        //list as Key is used here
        <li key={index}>{item}</li>
      ))}
    </ul>
  );
}
export default ListRendering;

//=======================
// The "Index as Key" anti-pattern occurs 
// when you use the array index as the key prop 
// for list items, as in key={index}. 
// While this approach works in some cases, 
// it can lead to issues when the list changes, such 
// as items being added or removed.


// import React from 'react';

// function IndexAsKey() {
//   const items = [
//     { id: 1, name: 'Item 1' },
//     // { id: 2, name: 'Item 2' },
//     { id: 3, name: 'Item 3' },
//   ];

//   return (
//     <ul>
//       {items.map((item) => (
//         //IndexAsKey
//         <li key={item.id}>{item.name}</li>
//       ))}
//     </ul>
//   );
// }

// export default IndexAsKey;