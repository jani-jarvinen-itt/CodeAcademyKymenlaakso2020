const express = require('express')
const app = express()
const port = 3000

app.get('/', (req, res) => {
  res.send("<!DOCTYPE html><html> " +
           "<head><link rel='stylesheet' href='staattiset/Testi.css'></head>" +
           "<body><h1>JavaScript-testi</h1></body></html>")
})

app.post('/', (req, res) => {
    
    const tila = {
        onnistui: false,
        virheilmoitus: "Tietokantavirhe."
    }
    res.json(tila)
    
    // res.send('Vastaus POST-pyyntöön.')
})

// staattisten tiedostojen määritys
app.use('/staattiset', express.static('staattiset'))

app.listen(port, () => {
  console.log(`Example app listening at http://localhost:${port}`)
})
