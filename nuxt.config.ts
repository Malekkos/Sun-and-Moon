// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  compatibilityDate: '2024-04-03',
  devtools: { enabled: true },
  css: ["~/assets/css/main.css"],

  postcss: {
    plugins: {
      tailwindcss: {},
      autoprefixer: {},
    }
  },

  runtimeConfig: {
    // This is an exposed data that can be grabbed serverside. The most obvious use is providing a key for authentication purposes. Maybe, a secret, as well
    // Another use could be derived from .env variables. Like, defined an api key or changing the project to production, rather than development.
    public: {
      // This is an exposed data that can be grabbed from clientside. Can be used to defined path names like :/api/
    }
  },

  modules: ["@nuxtjs/fontaine"]
})