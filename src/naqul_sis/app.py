import nltk
from nltk.corpus import wordnet


from flask import Flask
from flask import request,jsonify

app = Flask(__name__)

class WordNet:
    def get_synonyms_of_a_word(self, word):
        synonyms = []
        for syn in wordnet.synsets(word):
            for l in syn.lemmas():
                synonyms.append(l.name())
        return synonyms


@app.route('/sys', methods=['POST'])
def gen_query():
    body = request.get_json()
    word = body["word"]
    word = word.lower()

    wordnet = WordNet()
    sys = wordnet.get_synonyms_of_a_word(word)
    return jsonify(sys)


if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0',port=8081)