import React, { useState } from 'react';
import Child from './Child';

function Parent() {
    const [message, SetMesage] = useState('');


    const handleClick = () => {
        SetMesage('Button clicked in child');
    }

    return (
        <div>
            <Child onClick = {handleClick} />
            <p>{message}</p>
        </div>
    );
}

export default Parent;