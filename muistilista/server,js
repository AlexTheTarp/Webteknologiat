const express = require('express');
const cors = require('cors');
const fs = require('fs');
const path = require('path');

const app = express();
const PORT = 3000;

app.use(cors());
app.use(express.json());
app.use(express.static('public'));

const todosPath = path.join(__dirname, 'data', 'todos.json');

app.get('/tasks', (req, res) => {
    const data = JSON.parse(fs.readFileSync(todosPath, 'utf8'));
    res.json(data);
});

app.get('/task/:id', (req, res) => {
    const data = JSON.parse(fs.readFileSync(todosPath, 'utf8'));
    const task = data.find(t => t.id === parseInt(req.params.id));
    
    if (task) {
        res.json(task);
    } else {
        res.status(404).json({ error: "Tehtävää ei löytynyt" });
    }
});

app.listen(PORT, () => {
    console.log(`Palvelin käynnissä osoitteessa http://localhost:${PORT}`);
});