


<!--
This is the default entry point for the project. It will render its content on every route of the application
What needs to be here:
 ~ Header/Navbar
 ~ Footer

-->

<!-- 
If we would like to use global state, we can use pinia. I'm not totally sure where we would put the pinia file,
cont. but it would look something like below
  export const useWebsiteStore = defineStore('websiteStore', {
      state: () => ({
        name: '',
        description: ''
      }),
      actions: {
        async fetch() {
          const infos = await $fetch('https://api.nuxt.com/modules/pinia')

          this.name = infos.name
          this.description = infos.description
        }
      }
    })
The above defines a function called useWebsiteStore, which calls the defineStore method. We then provide a name,
cont. in this instance websiteStore, and go into the actual function. First, we define a function state, with whatever
cont. state we might need. Then we define actions. This will fetch the... params, I believe, from the pinia module. 
cont. Then, after that, we would use 'this.' to initialize these methods to be accessible globally. Keep in mind we
cont. have to install pinia in the modules for this to work. If we ever want to bring in a global state value, we
cont. can do the following:
  const website = useWebsiteStore()
  await callOnce(website.fetch)
We can then access the data using website.name or website.description
-->
<template>
  <div>
    <div>
      <p>Placeholder Navbar</p>
    </div>
    <NuxtLayout />
    <NuxtPage />
    <NuxtRouteAnnouncer />
    <NuxtWelcome />
    <div>
      <p>Placeholder Footer</p>
    </div>
  </div>
</template>
