const express = require('express')
const app = express()
const port = 3000

// staattisten tiedostojen määritys
app.use('/', express.static('.'))

app.listen(port, () => {
  console.log(`Web-palvelin käynnistetty osoitteeseen http://localhost:${port}`)
})
