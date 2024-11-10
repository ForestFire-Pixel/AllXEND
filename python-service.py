# python-service.py
from flask import Flask
app = Flask(__name__)

@app.route('/process')
def process():
    return "Python Service: Data processed successfully!"

if __name__ == '__main__':
    app.run(port=5000)
  
