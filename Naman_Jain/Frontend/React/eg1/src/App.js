import './App.css';
import {GreetFC} from "./components/GreetFC";
import GreetCC from './components/GreetCC';
import Counter from './components/Counter';
import Parent from './components/Parent';
import ConditionalRendering from './components/ConditionalRendering';

function App() {
  return (
    <div>
      {/* <h3>React Examples </h3>
      <GreetFC />
      <GreetCC />  */}
      {/* <Counter /> */}
      {/* <BindingEventHandlers /> */}
      {/* <Parent /> */}
      <ConditionalRendering />
    </div>
  );
}

export default App;
