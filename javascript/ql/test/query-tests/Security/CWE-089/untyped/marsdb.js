const express = require("express"),
  MarsDB = require("marsdb"),
  bodyParser = require("body-parser");

let doc = new MarsDB.Collection("myDoc");

const app = express();

app.use(bodyParser.urlencoded({ extended: true }));

app.post("/documents/find", (req, res) => {
  const query = {};
  query.title = req.body.title; // $ Source

  doc.find(query, (err, data) => {}); // $ Alert - query is tainted by user-provided object value
});
