// allxend-gateway.js
const express = require('express');
const axios = require('axios');
const app = express();
const PORT = 3000;

// Route to Python service
app.get('/process', async (req, res) => {
    try {
        const response = await axios.get('http://localhost:5000/process');
        res.send(response.data);
    } catch (error) {
        res.status(500).send('Python service failed');
    }
});

// Route to Go service
app.get('/concurrency', async (req, res) => {
    try {
        const response = await axios.get('http://localhost:6000/concurrency');
        res.send(response.data);
    } catch (error) {
        res.status(500).send('Go service failed');
    }
});

// Route to Java service
app.get('/auth', async (req, res) => {
    try {
        const response = await axios.get('http://localhost:7000/auth');
        res.send(response.data);
    } catch (error) {
        res.status(500).send('Java service failed');
    }
});

app.listen(PORT, () => {
    console.log(`AllXEND Gateway running on http://localhost:${PORT}`);
});
