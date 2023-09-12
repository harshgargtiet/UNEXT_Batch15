import React, {component} from 'react';

class BindingEventHandlers extends Component {
    constructor(props) {
        super(props);
        this.state = {message : 'Before click'}
        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() {
        this.setState('Button Click');
    }

    render() {
        return (
            <>
                <button onClick={this.handleClick}></button>
            </>
        );
    }
}