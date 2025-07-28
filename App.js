import React from 'react';
import Hello from './Hello';
import withLogger from './withLogger';

//use Decorator in react
const HelloWithLogger = withLogger(Hello);

function App() {
  return (
    <div>
      <HelloWithLogger name="Ali" />
    </div>
  );
}

export default App;