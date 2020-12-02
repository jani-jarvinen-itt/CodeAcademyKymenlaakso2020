const fetch = require("node-fetch");

fetch('https://jsonplaceholder.typicode.com/albums')
    .then(response => response.json())
    .then(json => {

        /*
          for (let index = 0; index < json.length; index++) {
              const element = json[index];
              console.log(element.title);
          }
        */

        for (albumi of json) {
            console.log(albumi.title);
        }
    });
