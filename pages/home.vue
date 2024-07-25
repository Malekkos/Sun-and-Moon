
<!-- 
First page of many!
This will be home, it will have some jumping off points to other sections of the website, and will
cont. function as a preview of some novels/features. This would be a good time to take from WebNovel;
cont. subpar leadership aside, it has a pretty good homepage IMO.

-->

<!-- 
Another useful feature, useSeoMeta({}). We can use this to define page meanings. Say we use description: "",
cont. this would show in page results when searching for things. We can also use ogImage:, ogDescription:(think
cont. like its summarized description), and more.
We can do the above inline with <Head> elements or <Title> elements, but i prefer putting them in script.
-->

<!-- 
Another useful feature, useFetch. Its a built in composable for the script tag, and one we'll use quite a bit.
cont. It acts as the fetcher for all the data from the server we are going to use. The following is how:
  const { data: count } = await useFetch('/api/count')
It seems like we would fetch the data from the url, and then assign it a value with const, the variable being data.
cont. Finally, we would use that data elsewhere in template, simply defined like this: {{ count }}. To put it simply,
cont. its like we are using an inline version of useState from react, just from the script this time.

Next would be the $fetch, and its what useFetch uses. While we would be using useFetch for GETS, we need to use $fetch
cont. for other methods, like POST. This is likely where we would set headers as well, im not sure.

Finally, if we want, we can use useAsyncData(). This does everything above while also giving a field for error. It looks
cont. like so:
  const { data, error } = await useAsyncData('users', () => myGetFunction('users'))
It would parse the responses data and error, while searching at the url 'users'. The function myGetFunction is a $fetch,
cont. and using a $fetch is completely fine in this instance.

An option on these fields, called pick: , is a nice tool to 'pick' out specific data from a large set.

We can also use transform, which would be when we are 'picking' specific data but for an array. Looks like the following:
  transform: (mountains) => {
      return mountains.map(mountain => ({ title: mountain.title, description: mountain.description }))

The above is all inside of our composable.
  -->

<template>
  <div>
    <NuxtLayout name="default">
      
    </NuxtLayout>
  </div>
</template>

<script lang="ts" setup>

</script>

<style>

</style>