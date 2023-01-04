const jsonServer = require('json-server');
const middleware = jsonServer.defaults();
const server = jsonServer.create();

server.use(middleware);
server.use(jsonServer.bodyParser);

const carData = require('../server/data/cars');

server.get('/api/car', (req, res, next) => {
  res.status(200).send(carData.getCars);
});

server.listen(3000, () => {
  console.log('JSON server listening on port 3000');
});