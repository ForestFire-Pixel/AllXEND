// typescript-service.ts
import express from 'express';
const app = express();

app.get('/typescript', (req, res) => {
    res.send('TypeScript Service: Message processed successfully!');
});

app.listen(8200, () => console.log('TypeScript Service running on http://localhost:8200'));
