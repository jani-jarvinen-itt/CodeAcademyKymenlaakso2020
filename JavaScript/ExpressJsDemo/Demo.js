const express = require('express')
const app = express()
const port = 3000

app.get('/', (req, res) => {
  res.send('Vastaus GET-pyyntöön.')
})

app.post('/', (req, res) => {
    
    const tila = {
        onnistui: false,
        virheilmoitus: "Tietokantavirhe."
    }
    res.json(tila)
    
    // res.send('Vastaus POST-pyyntöön.')
})

app.listen(port, () => {
  console.log(`Example app listening at http://localhost:${port}`)
})
