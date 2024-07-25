<!-- 
This should be the template page for the dynamic route system.
It would function(at least, as of now) by taking the param id/book name, passing that info
cont. to the database and searching it from there. This would be in the form of a call. Then,
cont. it would print out all the data here.
Issues:
 ~ First off, the one that comes to mind immediately, is the data passed. What I mean is not 
 cont. the normal data itself; name, description, chapters, what have you. More specifically, 
 cont. we would need pages/chapters that would link off of this page, and that could exceed a thousand.
 cont. This means we would have a dynamic route inside of a dynamic route. Not sure how that will work.

-->

<!-- 
Another useful feature, making changes in the head statement. We can use this to change the 
cont. title of the website to reflect that book name. We would do this through the useHead({})
cont. composable function
Something that cna go into useHead is titleTemplate. This seems to take the title originally and 
cont. make some changes on it, then change the title to the changes. We could make it so that the title
cont. is the book name, and then make it so that the resulting string/title would be the chapter you are on.
cont. Like so:
  titleTemplate: (titleChunk) => {
    return titleChunk ? `${titleChunk} - Chapter X` : 'book name here';
  }

-->

<!-- 
Another useful feature, useState. These are created in the script tag, and while having the same general meaning
cont. as React state, its executed differently. First, you would define the variable name for state, follow with
cont. invoking the useState ref, and provide it some params. The params are a unique key name to... reference it,
cont. I think? and finally, you can provide a function or value for an initial value it can hold. Below is an example
  const counter = useState('counter', () => Math.round(Math.random() * 1000))
The above can be accessed by using 'counter', and contains the reactive state currently available. I'm still not sure 
cont. if the key is necessary, nor am I sure what it really does.
-->

<!-- 
Something we will have to use, eventually, is <ClientOnly>. We need to do this because when the site is being pre-rendered
cont. , we will face issues of needed to render a thousand chapters. When defining <ClientOnly> the chapters will be rendered
cont. by the user, not by the server. 

Another method I just found was predefining components in the components structure to include client. Hence, it would read
cont. like: Book-Card.client.vue
If we do that, they must be imported from #components. Just keep that in mind.
Also, .client components are only rendered AFTER being mounted. So, in order to change data on a component like this, we 
cont. would have to use 'onMounted()', and then provide a 'await nextTick()' method inside of 'onMounted()'
-->

<template>
  <div>
    
  </div>
</template>

<script lang="ts" setup>

</script>

<style>

</style>