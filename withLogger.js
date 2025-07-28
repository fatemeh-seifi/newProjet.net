import React, { useEffect } from 'react';

const withLogger = (WrappedComponent) => {
  return function LoggerComponent(props) {
    useEffect(() => {
      console.log( `${WrappedComponent.name} mounted with props:, props`);
    }, []);

    return <WrappedComponent {...props} />;
  };
};

export default withLogger;