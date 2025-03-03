module.exports = {
  content: [
    "./Pages/**/*.{cshtml,razor}",
    "./wwwroot/**/*.{html,js}",
  ],
  theme: {
    extend: {
      colors: {
        'custom-blue': '#1e40af',
        'custom-purple': '#7c3aed',
        'custom-green': '#10b981',
        'custom-red': '#ef4444',
        'custom-yellow': '#f59e0b',
      },
    },
  },
  plugins: [],
};