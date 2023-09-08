import { useState } from "react";
import "./Counter.css";

const Counter = () => 
{
    const [count, setCount] = useState(0);

    const incrementCount = () => {
        if(count === 9) setCount(0);
        else setCount(count + 1);
    }
    const decrementCount = () => {
        if(count == 0) setCount(9);
        else setCount(count - 1);
    }
    return (
        <div className="counter__container">
            <h2 className="counter__header">Counter</h2>
            <p className="counter__board">Count: {count}</p>
            <div className="counter__controllers">    
                <button onClick={incrementCount}><h1>+</h1></button>
                <button onClick={decrementCount}><h1>-</h1></button>
            </div>
        </div>
    )
}

export default Counter;