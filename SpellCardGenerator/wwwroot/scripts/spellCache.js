const spellCacheKey = "spellcardgenerator.spells.v1";

window.spellCache = {

    getSpellJson: function () {
        return window.localStorage.getItem(spellCacheKey);
    },

    setSpellJson: function (spellJson) {
        window.localStorage.setItem(spellCacheKey, spellJson);
    },

    clearSpellJson: function () {
        window.localStorage.removeItem(spellCacheKey);
    }
};
