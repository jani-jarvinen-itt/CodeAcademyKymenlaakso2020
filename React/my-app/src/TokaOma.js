import KolmasOma from "./KolmasOma";

function TokaOma() {

    const taulukko = [1, 2, 3];
    const olio = {
        nimi: "Jaska Jokunen",
        kengännumero: 42
    };

    return (
        <div>
            <h1>Toinen komponentti</h1>
            <p>Tämä on TokaOma.js</p>

            <KolmasOma teksti="ABCD" lista={taulukko} henkilö={olio} />
            <KolmasOma luku={1234} />
            <KolmasOma teksti="BCDE" luku={2345} />
        </div>
    );
}

export default TokaOma;
