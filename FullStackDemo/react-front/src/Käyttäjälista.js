import React from 'react';

class Käyttäjälista extends React.Component {

    constructor(props) {
        super(props);
        this.state = { käyttäjät: [] };

        console.log("Käyttäjälista.constructor");
    }

    render() {

        console.log("Käyttäjälista.render");

        const lista = [];
        for (let index = 0; index < this.state.käyttäjät.length; index++) {
            const käyttäjä = this.state.käyttäjät[index];
            lista.push(<p>Id: {käyttäjä.id}, nimi: {käyttäjä.name}</p>);
        }

        return (
            <div>
                <h1>Tämä on Käyttäjälista-komponentti</h1>
                {lista}
            </div>
        );
    }
}

export default Käyttäjälista;
