const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');
const mongodb = require('mongodb');

const app = express();

app.use(bodyParser.json({ limit: '50mb' }));
app.use(cors());

app.get('/health', async (req, res) => {
    res.send("Health check: Management API active.");
});

app.get('/events', async (req, res) => {
    const events = await loadNewVideoEvents();
    res.send(await events.find().toArray());
});

app.get('/keys', async (req, res) => {
    const keys = await loadNewVideoKeys();
    res.send(await keys.find().toArray());
});

app.post('/project', async (req, res) => {
    const data = req.body;
    const project = await loadVideoViews();
    await project.insertOne({
        name: data.name,
        description: data.description,
        video: data.video,
        thumbnail: data.thumbnail,
    });
    res.send(true);
})

app.get('/project', async (req, res) => {
    const projects = await loadVideoViews();
    res.send(await projects.find().toArray());
})

const loadNewVideoEvents = async () => {
    const client = await mongodb.MongoClient.connect
    ('mongodb://ObsidianTech:Obsidian12!@ds131737.mlab.com:31737/nurenqa1', {
        useNewUrlParser: true
    });
    return client.db('nurenqa1').collection('newvideoevents');
};

const loadNewVideoKeys = async () => {
    const client = await mongodb.MongoClient.connect
    ('mongodb://ObsidianTech:Obsidian12!@ds131737.mlab.com:31737/nurenqa1', {
        useNewUrlParser: true
    });
    return client.db('nurenqa1').collection('nurenvideokeys');
};

const loadVideoViews = async () => {
    const client = await mongodb.MongoClient.connect
    ('mongodb://ObsidianTech:Obsidian12!@ds131737.mlab.com:31737/nurenqa1', {
        useNewUrlParser: true
    });
    return client.db('nurenqa1').collection('nurenvideoviews'); 
}

app.listen(process.env.PORT || 80);
console.log("Video Management API is running. ");