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
            lista.push(<tr key={id}>
                <td>{id}</td>
                <td>{asiakas.companyName}</td>
                <td>{asiakas.country}</td>
            </tr>);
        }

        return (
            <div>
                <h1>Tämä on Asiakaslistaus-komponentti</h1>
                <table className="table table-striped">
                    <thead>
                        <tr>
                            <th>Customer Id</th>
                            <th>Company Name</th>
                            <th>Country</th>
                        </tr>
                    </thead>
                    <tbody>
                        {lista}
                    </tbody>
                </table>
            </div>
        );
    }
}

export default Asiakaslistaus;
