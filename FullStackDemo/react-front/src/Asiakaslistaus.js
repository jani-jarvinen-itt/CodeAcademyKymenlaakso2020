import React from 'react';

class Asiakaslistaus extends React.Component {

    constructor(props) {
        super(props);
        this.state = { asiakkaat: [] };

        console.log("Asiakaslistaus.constructor");
    }

    componentDidMount() {

        console.log("Asiakaslistaus.componentDidMount");
        
        fetch("https://localhost:44393/api/customers")
            .then(response => response.json())
            .then(asiakkaat => {
            
                console.log(`Käyttäjädata ladattu! Tuloksia ${asiakkaat.length} kpl.`);

                this.setState({ asiakkaat: asiakkaat });
            });
    }

    render() {

        console.log("Asiakaslistaus.render");

        const lista = [];
        for (let index = 0; index < this.state.asiakkaat.length; index++) {
            const asiakas = this.state.asiakkaat[index];
            
            const id = asiakas.customerId;
            lista.push(<p key={id}>Id: {id}, nimi: {asiakas.companyName}</p>);
        }

        return (
            <div>
                <h1>Tämä on Asiakaslistaus-komponentti</h1>
                {lista}
            </div>
        );
    }
}

export default Asiakaslistaus;
