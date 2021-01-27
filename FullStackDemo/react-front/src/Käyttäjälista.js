import React from 'react';

class Käyttäjälista extends React.Component {

    constructor(props) {
        super(props);
        this.state = { käyttäjät: [] };

        console.log("Käyttäjälista.constructor");
    }

    componentDidMount() {

        console.log("Käyttäjälista.componentDidMount");
        
        fetch("https://jsonplaceholder.typicode.com/users")
            .then(response => response.json())
            .then(käyttäjät => {
            
                console.log(`Käyttäjädata ladattu! Tuloksia ${käyttäjät.length} kpl.`);

                this.setState({ käyttäjät: käyttäjät });
            });
    }

    render() {

        console.log("Käyttäjälista.render");

        const lista = [];
        for (let index = 0; index < this.state.käyttäjät.length; index++) {
            const käyttäjä = this.state.käyttäjät[index];
            
            const id = käyttäjä.id.toString();
            lista.push(<p key={id}>Id: {id}, nimi: {käyttäjä.name}</p>);
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
